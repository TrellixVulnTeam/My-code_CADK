def check_duyen(nguoiNam,nguoiNu):
    nguoiNam = nguoiNam.lower();
    nguoiNu = nguoiNu.lower();
    dem = 0;
    for ki_tu in range(ord('a'),ord('z')+1):
        if (chr(ki_tu) in nguoiNam) and (chr(ki_tu) in nguoiNu):
            dem = dem + 1;
    
    if dem == 0:
        rsl =  ('Người dưng nước lã!');
    elif dem <= 3:
        rsl = ('friend zone');
    elif dem > 3:
        rsl = ('Hai bạn rất hợp nhau');
    return rsl;


# ---------
print ("Nhập tên người nam: "); nam = input();
print ("Nhập tên người nữ: "); nu = input();
print ('Result: ' + str(check_duyen(nam, nu)));

