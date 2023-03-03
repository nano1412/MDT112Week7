using System;

namespace costomname {
     class Program {            
          static void Main(string[] args) {
               //odd();
               //timesquare();
               //dowhile();
               //loopinception();
               //trianglenumber();
               //whyme();
               //square();
               //diamond();
          }
          static void odd (){
               int number;
               int confirm = 2;
               while(true){
                    number = int.Parse(Console.ReadLine());
                         if(number % 2 == 0){
                              Console.WriteLine("even");
                         }
                         else{
                              confirm--;
                              if(confirm > 0){
                                   Console.WriteLine("-1");
                              }
                              else {
                                   break;
                              }
                         }
                    }
               }
          static void timesquare (){
               int num1 = 1;
               int num2 = 1;
               int output;
               for(;num1<=10;num1++){
                    output = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, output);
                    num2 = num2 * 2;

               }
          }
          static void dowhile(){
               int sum = 0;
               int i = 1;
               do{
                    sum = sum + 1;
                    i++;
                    Console.WriteLine("{0} {1}", i, sum);
               }while(i < 0);
          }

          static void loopinception(){
               for(int row = 1; row <= 5; row++){
                    for(int col = 1; col <= 6; col++){
                         Console.WriteLine("({0},{1})",row ,col);
                    }
               }
          }

          static void trianglenumber(){
               int height = int.Parse(Console.ReadLine());
               for(int i = 1; i <= height; i++){
                    for(int j = 1; j <= i; j++){
                         Console.Write("{0} ",j);
                    }
                    Console.Write("\n");
               }
          }

          static void whyme(){
               int height = int.Parse(Console.ReadLine());
               height--;
               for(int i = 0; i < height; i++){
                    for(int j = height; j > i; j--){
                         Console.Write(" ");     
                    }
                    if(i > 0){
                         Console.Write("*");
                    }
                    int k = 0;
                    while(true){
                         if(k >= (i*2)-1){
                              break;
                         }
                         Console.Write(" ");
                         k++;       
                    }
                    Console.WriteLine("*"); 
               }
               for(int i = 0; i < (height * 2)+1;i++){
                    Console.Write("*");
               }
          }

          static void square(){
                         int height = int.Parse(Console.ReadLine());
                         for(int i = height;i >= 0; i--){
                              Console.Write("* ");
                         }
                         
                         for(int i = height - 2;i >= 0; i--){
                              Console.Write("\n*");
                              for(int j = height - 2;j >= 0; j--){
                                        Console.Write("  ");
                              }
                              Console.Write(" *");
                         }
                         Console.Write("\n*");

                         for(int i = height;i > 0; i--){
                              Console.Write(" *");
                         }

                    }
          static void diamond(){
               int height = int.Parse(Console.ReadLine());
               for(int i = 0; i < height; i++){
                    for(int j = height - 1; j > i; j--){
                         Console.Write(" ");     
                    }
                    if(i > 0){
                         Console.Write("*");
                    }
                    for(int k = 0; k < (i*2)-1; k++){
                         Console.Write(" ");
                    }
                    Console.WriteLine("*"); 
               }

               height--;
               for(int i = height; i > 0 ; i--){
                    for(int j = height; j >= i; j--){
                         Console.Write(" ");
                    }
                    if(i > 1){
                         Console.Write("*");
                    }
                    for(int k = 0; k < (i*2)-3; k++){
                         Console.Write(" ");
                    }
                    Console.WriteLine("*");
               }
          }
     }
}