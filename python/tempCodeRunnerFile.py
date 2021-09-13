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
print(pd.DataFrame(data))