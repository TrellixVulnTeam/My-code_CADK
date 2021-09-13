import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
from xlwt.ExcelFormula import Formula

path = "C:\\Users\\dat54\\OneDrive\\Desktop\\Learning\\python\\bieuDo1.xlsx"

data = {'STT':[1,2,3,4,5,6,7],
        'Tên': ['Hoa Cải', 'Hoa Cúc', 'Hoa Lan', 'Hoa Huệ', 'Hoa Giấy', 'Hoa Mai', 'Hoa Tulip'],
        'Nơi trồng':['Đà lạt','Cần Thơ','Long An','Tiền Giang','Vĩnh Long','Bến Tre','Đắk Lắk'],
        'Số lượng':[100,280,475,624,752,478,354],
        'Giá':[10,15,30,45,78,92,47]
        }
print(pd.DataFrame(data)) # lấy dữ liệu của data
df = pd.DataFrame(data, columns=['STT','Tên','Nơi trồng','Số lượng','Giá']) # DF cấu trúc chữa dl 2 chiều
#câu a: vẽ biểu đồ

#region biểu đồ hình tròn
plt.pie(df['Số lượng'],labels=df['Tên'], autopct='%1.1f%%')
plt.title("biểu đồ hình tròn")
plt.show()


#region biểu đồ hình trụ
plt.bar(df['Tên'],df['Số lượng'],color='skyblue' )
plt.title('biểu đồ hình trụ')
plt.xlabel('loại hoa')
plt.ylabel('số lượng')
plt.show()

#câu b: tính tổng giá tiền cảu trái cây
print('tổng giá tiền: ',df["Giá"].sum())


#câu c & d: lưu dữ liệu vào file, lưu và in ra màn hình
df.to_excel(path, index=False) #cr, wr & s
print(pd.read_excel(path))


#e: cột tổng ở câu b lưu xuống file xyz
df['Tổng'] = df['Số lượng'] * df['Giá']
print(df)
df.to_excel(path)



#max:
print("Trái cây có giá thấp nhất là: ",df['Tên'].min(),",có giá: ",df['Giá'].min())
print("Trái cây có số lượng ít nhất là: ",df['Tên'].min(),",số lượng: ",df['Số lượng'].min())