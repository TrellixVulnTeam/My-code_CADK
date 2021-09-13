def nhap():
    a = int(input('enter a: '))
    b = int(input('enter b: '))
    if a >= b:
        print('vui long nhap a < b')
        nhap()
    else:
        j = []
        for i in range(a,b):
            if(i%7==0 and i % 5==0):
                j.append(str(i))
        print(j)
nhap()