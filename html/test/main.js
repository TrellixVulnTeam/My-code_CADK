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



var date = new Date();
var year = date.getFullYear();
var month = date.getMonth();
console.log(typeof year)
console.log(month) + 1;
console.log(date.getDay());


switch (3) {
    case 2:
        console.log('Hom nay la thu 2')
        break;
    case 3:
        console.log('Hom nay la thu 3')
        break;
    case 4:
        console.log('Hom nay la thu 4')
        break;
    case 5:
        console.log('Hom nay la thu 5')
        break;
    case 6:
        console.log('Hom nay la thu 7')
        break;
    case 8:
        console.log('Hom nay la Chu Nhat')
        break;
    case 2:
        console.log('Hom nay la thu 2')
        break;

    default:
        break;
}