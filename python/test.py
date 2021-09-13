# c = 4
# b = 6
# t = 'false' if a > b else 'true'
# print (t)

# fine max
# a = int(input('enter a: '))
# b = int(input('enter b: '))
# c = int(input('enter c: '))
# max = a
# if b > max:
#     max = b
# if c > max:
#     max = c
# print ('max= ',max)

#while
# count = 0
# while count < 5:
#     print(count)
#     count+=1
# else:
#     print('count khong lon hon 5')

# so chan 1 - 100
# i = 1
# while i <= 100:
#     if i%2==0:
#         print(i)
#     i+=1

# so 1 - 100 chia het cho 3
# for i in range(1,100):
#     if i % 3 == 0:
#         print(i)


# so tu 1 - 100 co tich & 2(sum) 
# for i in range(1, 10):
#     for j in range(1,10):
#         if i*j==2*(i+j):
#             print(i*10+j)

# func
# def tong(a,b):
#     return a + b
# def hieu(a,b):
#     return a - b
# def tich(a,b):
#     return a*b
# def thuong(a,b):
#     return a/b
# def nhap():
#     a = int(input('enter a: '))
#     b = int(input('enter b: '))
#     print ("tong = ",tong(a,b))
#     print ("hieu = ",hieu(a,b))
#     print ("tich = ",tich(a,b))
#     while a == 0:
#         print('thuong, nhap a > 0')
#         nhap()
#         break
#     else:
#         print("thuong: ",(thuong(a,b)))
# nhap()


# dat = 'dat '
# print(dat*3)

# lst = [['dat'],[123]]
# lst3 = ['q','w','r','t','f','h','d','d','w']
# lst2 = [n for n in range(50)]
# for i in lst:
#         print(lst)
# print (lst2)
# def cmp(a, b):
#     return (a > b) - (a < b) 
# a = [1,2,3]
# b = [1,2,3,1]

# c = cmp(a,b)
# print (c)

#tuple

# count = 0
# t = ()
# while count < 5:
#     count+=1
#     x = int(input('enter: '))
#     t+=(x,)
# print(t)
# print(t.count(4))
# print(max(t))
# print(sorted(t,reverse=1))