namespace Example;

class Example{
    public static int MaxValue(Span<int> arr){
	if(arr.Length == 1){
	    return arr[0];
	}

	Span<int> newSpan = arr.Slice(1);
	
	return Math.Max(arr[0],MaxValue(newSpan));
    }
}
