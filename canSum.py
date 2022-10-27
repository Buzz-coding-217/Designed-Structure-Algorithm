# Python program for implementation of canSum
def canSum(S, x):
    # initialising a bool to false
    result = False

    # dividing the array till each element present on its own array
    if len(S) > 1:
        mid = len(S) // 2
        L = S[:mid]
        R = S[mid:]

        # Running recursively on two divided arrays
        result = canSum(L,x) or canSum(R,x)

        # Checking if there exist a pair whose sum is equal to target
        i = j = 0
        while i < len(L) and j < len(R):
            if L[i] + R[j] == x:
                result = True
            i += 1
            j += 1
    # returning either true or false
    return result


if __name__ == '__main__':
    # Checking the working of the algorithm
    arr = [12, 11, 13, 5, 6, 7]
    print(canSum(arr, 11))
    print(canSum(arr, 10))

