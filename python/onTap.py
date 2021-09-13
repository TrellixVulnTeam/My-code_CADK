from typing import Match
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

# đường dẫn file
path = "C:\\Users\\dat54\\OneDrive\\Desktop\\test.xlsx"

# tạo từ điển chứa dữ liệu
data = {
    'STT':[1,2,3,4,5,6,7],
    'Tên':['Cam', 'Xoài', 'Mít', 'Ổi', 'Vải', 'Táo', 'Lê'],
    'Nơi trồng':['Việt Nam','Ấn','Việt Nam', 'Nhật', 'Việt Nam', 'Mỹ', 'Hàn'],
    'Số lượng':[50,75,500,192,178,300,200],
    'Giá':[2,3,45,7,5,6,8]
}
# print(pd.DataFrame(data))
df = pd.DataFrame(data,columns=['STT','Tên','Nơi trồng', 'Số lượng','Giá'])

# vẽ biểu đồ

# tròn
plt.pie(df['Số lượng'],labels=df['Tên'], autopct='%1.1f%%')
plt.title('Biểu đồ hình tròn')
plt.show()
# cột
plt.bar(df['Tên'], df['Số lượng'], color = 'skyblue')
plt.title('Biểu đồ hình trụ')
plt.xlabel('Tên quả')
plt.ylabel('Số Lượng')
plt.show()

# tính tổng giá tiền các loại trái cây
print('Tổng giá tiền: ',df['Giá'].sum())

# lưu dữ liệu vào file abc.xlsx
df.to_excel(path,index=False)

# đọc dữ liệu mới lưu
print("Đọc dữ liệu mới lưu")
print(pd.read_excel(path))

# tổng giá tiền lưu vào file
print('Thêm cột Tổng')
df['Tổng'] = df['Giá']*df['Số lượng']
print(df)
df.to_excel(path)

# Loại cây có tổng lớn nhất, nhỏ nhất và trung bình
print('Cây có tổng lớn nhất')
print(df[df['Tổng'] == df['Tổng'].max()])
print('Cây có tổng nhỏ nhất')
print(df[df['Tổng'] == df['Tổng'].min()])
print('Trung bình giá trị tổng cột')
print(round(df['Giá'].mean(),2))

