# maakav
```cs
static int Sod1(int n1, int n2) {
    if (n1 == 0 && n2 == 0)
        return 0;
    if (n2 != 0 && n1 == 0)
        return 1 + Sod1(0,n2/10);
    if (n2 == 0 && n1 != 0)
        return 1 + Sod1(n1 / 10, 0);
    return Sod1(n1 / 10, n2/10);
}

static int Sod2(int[] a, int n, int k) {
    if (k == n - 1)
        return Sod1(a[k], a[k + 1]);
    else {
        return Math .Max(Sod2(a, n, k + 1), Sod1(a[k], a[k + 1]));
    }
}

static void Main(string[] args) {
    int [] a={9321,345,296,7,98};
    Console.WriteLine(Sod1 (31547,86));
    Console.WriteLine(Sod2(a,4,0));
}
```
a = [9321,345,296,7,98]
Sod1(31547,86){
    if(31547 == 0 /*false*/ && ....){
    ...
    }
}
