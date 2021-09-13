#include<stdio.h>
#include <time.h>
    void delay(int number_of_seconds)
{
    int milli_seconds = 10 * number_of_seconds;
    clock_t start_time = clock();
    while (clock() < start_time + milli_seconds);
}
int main()
{
    int i, j, n = 0;
    for (i = 0; i < 22; i++)
    {
        if (i == 7)
            n = 0;
        else if (i == 14)
            n = 0;
        else if (i == 16)
            n = 0;
        for (j = 0; j < 43; j++)
        {
            if (i < 7 && j >= 21 - n && j <= 21 + n)
            {
                printf(".");
            }
            else if (i >= 7 && i <= 13 && j >= n * 2 + 1 && j <= 42 - n * 2 - 1)
            {
                printf(".");
            }
            else if (i >= 14 && i <= 15 && j >= 13 - n - 1 && j <= 29 + n + 1)
            {
                printf(".");
            }
            else if (i >= 16 && i <= 20 && j >= 11 - n - 1 && j <= 22 - (n * 4) || i >= 16 && i <= 20 && j <= 31 + n + 1 && j >= 20 + (n * 4))
            {
                printf(".");
            }
            else
            {
                printf("~");
            }
            delay(1);
        }
        n++;
        printf("\n");
        delay(1);
    }
    printf("\n\n Viet Nam Vo Dich\n\n");
}