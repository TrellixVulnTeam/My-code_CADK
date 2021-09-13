def giaiThua(n):
    gt = 1
    if n == 0 or n == 1:
        return gt
    else:
        for i in range(2,n+1):
            gt *= i
        return gt
        