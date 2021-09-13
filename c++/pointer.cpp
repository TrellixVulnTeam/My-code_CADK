#include <iostream>

struct conNguoi
{
    conNguoi (int t, float cc, float cn, bool gt){
        tuoi = t;
        chieuCao = cc;
        canNang = cn;
        gioiTinh = gt;
    }
    int tuoi;
    float chieuCao, canNang;
    bool gioiTinh;
};

int main (){
    conNguoi Hoa(19, 1.6, 45, 0);
    conNguoi Thao(20, 1.6, 55, 0);
    conNguoi Phuoc(20, 1.76, 50, 1);

    conNguoi *friend = nullptr;
    friend = &Phuoc;
    Thao.tuoi = 21;
    std::cout <<(*friend).tuoi << std::endl;
    return 0;
}