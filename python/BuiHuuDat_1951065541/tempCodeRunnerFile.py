# câu 3
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
plt.bar(df['Tên thiết bị'], df['Số lượng'], color = 'yellow')
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