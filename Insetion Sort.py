def Insertion_Algothim(a):
    for j in range(1, len(a)):
        key = a[j]
        i = j - 1
        while i >= 0 and a[i] > key:
            a[i + 1] = a[i]
            i -= 1
        a[i + 1] = key

print("Name: Hazem Ibrahim Abdel-Hamed Mohamed Aldriny >> Section:3")
print("---------------------------------")
arr = [ 15, 10, 25, 20, 30, 40, 35]
print("Original array:",arr)
print("---------------------------------")
Insertion_Algothim(arr)
print("Sorted array:",arr)
