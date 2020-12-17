import face_recognition
import os
import sys
from cv2 import cv2


KNOWN_FACES_DIR = 'known_faces'
UNKNOWN_FACES_DIR = 'unknown_faces'
TOLERANCE = 0.6
FRAME_THICKNESS = 3
FONT_THICKNESS = 2
MODEL = 'cnn'  # padrão: 'hog', outro pode ser 'cnn' - modelo pré-treinado de aprendizado profundo acelerado por CUDA (se disponível)


# Retorna (R, G, B) do nome
def name_to_color(name):
    # Pegue as 3 primeiras letras, tolower ()
    # O valor ord () do caractere minúsculo, está na faixa entre 97 a 122, subtrai 97, multiplica por 8
    color = [(ord(c.lower())-97)*8 for c in name[:3]]
    return color


print('Carregando faces...')
known_faces = []
known_names = []

# Organizamos rostos conhecidos como subpastas de KNOWN_FACES_DIR
# Cada nome de subpasta se torna nosso rótulo (nome)
for name in os.listdir(KNOWN_FACES_DIR):

    # Em seguida, carregamos todos os arquivos de rostos de pessoas conhecidas
    for filename in os.listdir(f'{KNOWN_FACES_DIR}/{name}'):

        # Carregando Imagens
        image = face_recognition.load_image_file(f'{KNOWN_FACES_DIR}/{name}/{filename}')

        # Obtenha codificação facial em 128-dimension
        # Sempre retorna uma lista de faces encontradas, para este propósito, pegamos a primeira face apenas (assumindo uma face por imagem, pois você não pode estar duas vezes em uma imagem)
        try:
            encoding = face_recognition.face_encodings(image)[0]
        except IndexError as e:
            print('Rosto não detectado na imagem')
            sys.exit(1)

        # Anexar codificações e nome
        known_faces.append(encoding)
        known_names.append(name)


print('Processing unknown faces...')
# Agora vamos percorrer uma pasta de rostos que queremos rotular
for filename in os.listdir(UNKNOWN_FACES_DIR):

    # Carrega imagem
    print(f'Filename {filename}', end='')
    image = face_recognition.load_image_file(f'{UNKNOWN_FACES_DIR}/{filename}')

    # Desta vez, primeiro pegamos os locais dos rostos - vamos precisar deles para desenhar caixas
    locations = face_recognition.face_locations(image, model=MODEL)

    # Agora, uma vez que conhecemos as localizações, podemos passá-las para face_encodings como segundo argumento
    # Sem isso, ele irá procurar por rostos mais uma vez, retardando todo o processo
    encodings = face_recognition.face_encodings(image, locations)

    # Passamos nossa imagem por face_locations e face_encodings, para que possamos modificá-la
    # Primeiro precisamos convertê-lo de RGB para BGR, pois vamos trabalhar com o cv2
    image = cv2.cvtColor(image, cv2.COLOR_RGB2BGR)

    # Mas, desta vez, presumimos que pode haver mais rostos em uma imagem - podemos encontrar rostos de pessoas diferentes
    print(f', found {len(encodings)} face(s)')
    for face_encoding, face_location in zip(encodings, locations):

        # Usamos compare_faces (mas também podemos usar face_distance)
        # Retorna a matriz de valores True / False na ordem das faces_conhecidas passadas
        results = face_recognition.compare_faces(known_faces, face_encoding, TOLERANCE)

        # Uma vez que a ordem está sendo preservada, verificamos se alguma face foi encontrada e então pegamos o índice
        # em seguida, rótulo (nome) da primeira face conhecida correspondente dentro de uma tolerância
        match = None
        if True in results:  # Se pelo menos um for verdadeiro, obtenha o nome do primeiro dos rótulos encontrados
            match = known_names[results.index(True)]
            print(f' - {match} from {results}')

            # Cada local contém posições em ordem: superior, direita, inferior, esquerda
            top_left = (face_location[3], face_location[0])
            bottom_right = (face_location[1], face_location[2])

            # Obtenha a cor pelo nome usando nossa função acima
            color = name_to_color(match)

            # Desenha o retângull
            cv2.rectangle(image, top_left, bottom_right, color, FRAME_THICKNESS)

            # Agora precisamos de um quadro menor preenchido abaixo para um nome
            # Desta vez, usamos a parte inferior em ambos os cantos - para começar da parte inferior e mover 50 pixels para baixo
            top_left = (face_location[3], face_location[2])
            bottom_right = (face_location[1], face_location[2] + 22)

            # Imprime o retângulo
            cv2.rectangle(image, top_left, bottom_right, color, cv2.FILLED)

            # Escreve o nome
            cv2.putText(image, match, (face_location[3] + 10, face_location[2] + 15), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (200, 200, 200), FONT_THICKNESS)

    # Mostra a Imagem
    cv2.imshow(filename, image)
    cv2.waitKey(0)
    cv2.destroyWindow(filename)