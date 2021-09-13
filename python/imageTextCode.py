path="C:/Users/dat54/OneDrive/Desktop/Learning/python/image-textCode.txt"

with open(path,mode='r', encoding='utf-8') as f:

    content = f.readlines()
    for i in range(len(content)):
        print(content[i])
    f.close()