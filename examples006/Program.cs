﻿int a = 2;
int b = 3;
int c = 5;
int d = 8;
int e = 6;

int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("max = ");
Console.WriteLine(max);