﻿// Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

string [] arr = new string [] {"Hello", "2", "world", ":-)"};
int N = 3;
int newsize = 0;
int newindex = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i].Length<=N)
    {
        newsize++;
    }
}
string[ ] newarr = new string [newsize];
for (int i = 0; i < arr.Length; i++)
{
 if(arr[i].Length<=N)
 {
    newarr[newindex]=arr[i];
    newindex++;
 }   
}