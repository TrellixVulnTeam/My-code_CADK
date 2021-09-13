t = tuple()
for i in range (1,1000):
    # print(i)
    dem = 0
    for j in range(1,i+1):
        if (i%j==0):
            dem+=1
    if dem == 2:
        t += (i, )
print(t)
        