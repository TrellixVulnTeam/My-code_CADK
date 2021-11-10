//confirm('Xac nhan ban du tuoi') //hien thi thong bao xac nhan
//prompt('xac nhan ban du tuoi') // giong ham confirm nhung hien them o massage

// set time chay code
// setTimeout(function() {
//     alert('dat')
// },1000)

// setInterval(function() {
//     var i = 0; i=i+1
//     console.log('i = '+ Math.random())
// },1000)

// var a = 2
// var b = 6
// console.log(a+b)//8
// console.log(a-b)//-4
// console.log(a*b)//12
// console.log(a/b)//0.3333
// console.log(a**b)//64
// console.log(a++)//3
// // console.log(b--)//6
// console.log(--a)//1
// console.log(++b)//1


// var myObject = [ 
//     'dat',
//     12,
// ]

// console.log(myObject)



// result = NaN || 'B' || null || 'D'

// console.log(result)
// if (result){
//     console.log('true');
// }else{
//     console.log('false');
// // }

// let users = function(firstName, lastName, old, sex, gmail) {
//     this.firstName = firstName;
//     this.lastName = lastName;
//     this.old = old;
//     this.sex = sex;
//     this.gmail = gmail;
//     this.getName = function(lenght){
//         this.lenght = lenght;
//         return `${this.firstName} ${this.lastName}`;
//     }
// }

// let a = new users('Bui Huu', 'Dat', 12, 'Nam','dat54261001@gmail.com',1.7);
// let b = new users('Truong Thi Quynh', 'Hoa', 12, 'Nu','QuynhHoa@gmail.com');

// console.log(a.getName.length);
// console.log(b);



// var date = new Date();
// var year = date.getFullYear();
// var month = date.getMonth();
// console.log(typeof year)
// console.log(month) + 1;
// console.log(date.getDay());


// switch (3) {
//     case 2:
//         console.log('Hom nay la thu 2')
//         break;
//     case 3:
//         console.log('Hom nay la thu 3')
//         break;
//     case 4:
//         console.log('Hom nay la thu 4')
//         break;
//     case 5:
//         console.log('Hom nay la thu 5')
//         break;
//     case 6:
//         console.log('Hom nay la thu 7')
//         break;
//     case 8:
//         console.log('Hom nay la Chu Nhat')
//         break;
//     case 2:
//         console.log('Hom nay la thu 2')
//         break;

//     default:
//         break;
//  }


// for (var i = 100; i >= 0; i-=5) {
//     console.log(i);
// }

var data = [{
    monan: "Tôm Hấp Nước Dừa",
    gia: 300000,
    anh: "tomnuong.jfif"
  },
  {
    monan: "Cua Đá Nướng Mọi",
    gia: 400000,
    anh: "cuada.jfif"
  },
  {
    monan: "Cá lóc Nướng Mọi",
    gia: 200000,
    anh: "caloc.jfif"
  },
  {
    monan: "Cáu lóc Nướng Mọi",
    gia: 200000,
    anh: "caloc.jfif"
  },
  {
    monan: "Cáo lóc Nướng Mọi",
    gia: 200000,
    anh: "caloc.jfif"
  },
]

// var arr = [2,5,6,7,3,4,66,4,[3,5,6,33,3,5,3],5,3,34,23,34,6,3,4,[3],6,2,3,5,2,3]
// var totalMonAn = data.reduce((a,b) => a+b.gia,0);

// console.log(tt);

// var showArray = data.reduce((a,b) => a.concat(b.monan),[])
// var showArray1 = data.reduce((a,b) => a.concat(b.gia),[])
// var showArray2 = data.reduce((a,b) => a.concat(b.anh),[])
// console.log(showArray)
// console.log(showArray1)
// console.log(showArray2)

// console.log(dataJs)


// console.log(Math.random()%2==0)

// var callback = data.reduce((a,b) => b.monan.includes('Cua')?this:b.monan,1)
// // console.log(callback)

// data.forEach(e => {
//   console.log(e.monan)
// })

// var forArr = function(){
//   for (var a in data) {
//     console.log(a)
//   }
// }
// function forEach2(cons){
//   for (var a in data) {
//     console.log(a)
//   }
// }
// data.forEach2(cons)


// function deQuy(num){
//   if (num <= 0) {
//     return num;
//   }
//   console.log(num);
//   deQuy(num-1);
// }

// deQuy(10)


function giaiThua(num){
  if(num<=0) {
    return 1;
  }
  return num * giaiThua(num-1);
}

console.log(giaiThua(7))