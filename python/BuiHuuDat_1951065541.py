# name: Bùi Hữu Đạt
# msv: 1951065541
# class: S22-61TH1

# câu 1
import BuiHuuDat_1951065541_module as md
n = int(input('Nhập n: '))
print(n,'giai thừa =',md.giaiThua(n))


# câu 2
def hienThi(s):
    demChuHoa = 0
    demChuThuong = 0
    for c in s:
        if c.isupper():
            demChuHoa = demChuHoa + 1
        if c.islower():
            demChuThuong = demChuThuong + 1
    print('Chuỗi đã nhập: ',s)
    print('Số chữ hoa: ',demChuHoa)
    print('Số chữ thường: ',demChuThuong)
s = str(input('Mời bạn nhập chuỗi: '))
hienThi(s)


# câu 3
# a
t = tuple([11,12,13,14,15,16,17,18,19,20])
t2 = tuple()
print(t)
for i in range (len(t)):
    if t[i]%2!=0:
        t2+=(t[i],)    
print('Tuple chứa số lẻ: ',t2)

# b
import matplotlib.pyplot as plt
import matplotlib.image as img
image = img.imread("C:\\Users\\dat54\\OneDrive\\Desktop\\BuiHuuDat_1951065541\\cat.jpg")
fig,axs = plt.subplots(2,2,figsize = (1,1),dpi=128)
axs[0,0].imshow(image)
axs[1,1].imshow(image)
axs[1,0].imshow(image)
axs[0,1].imshow(image)
plt.savefig('a.png')
plt.savefig('a.pdf')
plt.show()


# câu 4
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
data = {
    'STT':[1,2,3,4,5,6,7],
    'Tên thiết bị':['Điện thoại','Máy tính','Ipad','Tivi','Bếp điện','Bàn ủi','Tủ lạnh'],
    'Nơi sản xuất':['Việt Nam','Việt Nam', 'Thái Lan', 'Trung Quốc','Trung Quốc','Thái Lan','Thái Lan'],
    'Số lượng':[10,15,48,78,92,145,178],
    'Đơn giá/thiết bị':[120,400,260,150,99,124,580],
    'Tổng':[]
}
df = pd.DataFrame(data,columns=['STT','Tên thiết bị','Nơi sản xuất', 'Số lượng','Đơn giá/thiết bị'])

# a
plt.bar(df['Tên thiết bị'], df['Số lượng'], color = 'yellow,blue')
plt.title('Biểu đồ hình trụ')
plt.xlabel('Tên thiết bị')
plt.ylabel('Số Lượng')
plt.show()

plt.pie(df['Số lượng'],labels=df['Tên thiết bị'], autopct='%1.1f%%')
plt.title('Biểu đồ hình tròn')
plt.show()

# # b
df['Tổng'] = df['Số lượng']*df['Đơn giá/thiết bị']
print(df)

# # c
df.to_excel("C:\\Users\\dat54\\OneDrive\\Desktop\\BuiHuuDat_1951065541\\abc.xlsx",index=False)
print("Đọc dữ liệu mới lưu")

# # d
print(pd.read_excel("C:\\Users\\dat54\\OneDrive\\Desktop\\BuiHuuDat_1951065541\\abc.xlsx"))