with open("C:\\Users\\dat54\\OneDrive\\Desktop\\Learning\\python\\docFile1.txt",mode = 'r', encoding='utf-8') as f:
    content = f.readlines()
    doanDaiNhat = content[0]
    for i in range(len(content)):
        if len(doanDaiNhat) < len(content[i]):
            doanDaiNhat = content[i]
    f.close
print(doanDaiNhat)