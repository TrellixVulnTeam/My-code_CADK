with open("C:\\Users\\dat54\\OneDrive\\Desktop\\Learning\\python\\docFile2.txt", mode = 'w', encoding='utf-8') as f:
    f.write('fullName: Bui Huu Dat\nstudentCode: 1951065541\nbirthDat: 26/10/2001\nborn: Nam Dinh\nphoneNumber: 0987651053')
    f.closed
with open("C:\\Users\\dat54\\OneDrive\\Desktop\\Learning\\python\\docFile2.txt", mode = 'r', encoding='utf-8') as f:
    content = f.readlines()
    for i in range(len(content)):
        if i > len(content)-2:
            print(content[i])
    f.close
    