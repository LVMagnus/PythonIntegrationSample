import math


def Permutation(elementPoolSize, selectionSize, repetitionAllowed = False):
    """
       Calculates how many ways n elements can be arranged in p positions when order of elements do matter.
       Invalid or out of bounds selectionSize = short cut for selectionSize equal to elementPoolSize
    """
        

    #Input error handling

    if type(elementPoolSize) != int:
        raise TypeError("elementPoolSize has to be of int type.")

    if type(selectionSize) != int:
        raise TypeError("selectionSize has to be of int type.")
    

    if elementPoolSize <= 0:
        raise ValueError("elementPoolSize cannot be less than 1.")
    
    if selectionSize <= 0:
        raise ValueError("selectionSize cannot be less than 1.")

    if not repetitionAllowed and selectionSize > elementPoolSize:
       raise ValueError("If repetitionAllowed is false, elementPooSize has to be less than or equal to seelctionSize.")


 
   #Main code

    result = 1
    
    if repetitionAllowed:
        result = elementPoolSize ** selectionSize
    else:    
        for i in range(elementPoolSize, elementPoolSize-selectionSize,-1):
            result = result * i
        #end for
    #end if-else

    return int(result)
#end def Permutation(elementPoolSize, selectionSize, repetition)




def Combination(elementPoolSize, selectionSize, repetitionAllowed = False):
    """
       Calculates how many ways n elements can be arranged in p positions when order of elements does not matter.
    """

    #Input error handling
    if type(elementPoolSize) != int:
        raise TypeError("elementPoolSize has to be of int type.")

    if type(selectionSize) != int:
        raise TypeError("selectionSize has to be of int type.")
    
    
    if elementPoolSize < 1:
        raise ValueError("elmentPoolSize cannot be less than 1.")

    if selectionSize < 1:
        raise ValueError("selectionSize cannot be less than 1.")

    if not repetitionAllowed and selectionSize > elementPoolSize:
       raise ValueError("If repetitionAllowed is false, elementPooSize has to be less than or equal to seelctionSize.")



    
    #main code
    
    if repetitionAllowed:
        return int(math.factorial((selectionSize + elementPoolSize - 1)) / ( math.factorial(selectionSize) * math.factorial(elementPoolSize-1)))
    else:
        return int(math.factorial(elementPoolSize) / ( math.factorial(selectionSize) * math.factorial(elementPoolSize-selectionSize)))
#end def Combination(elementPoolSize, selectionSize, repetition)




