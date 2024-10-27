namespace Program;
internal class Program{

    static double Average(int[,] arr){
	double counter = 0D;
	for(int i = 0;i<arr.GetLength(0);i++){
	    for(int j = 0;j<arr.GetLength(1);j++){
		counter += arr[i,j];
	    }
	}
	return counter/arr.Length;
    }

    static bool MagicSquare(int[,] arr){
	int predicate = 0;
	int len0 = arr.GetLength(0);
	for(int i = 0;i<len0;i++){
	    predicate+= arr[0,i];
	}
	for(int i = 1; i<len0;i++){
	    var cursum = 0;
	    for(int j = 0; j<len0; j++){
		cursum+=arr[i,j];
	    }
	    if(cursum!=predicate) return false;
	}
	for(int i = 0;i<len0;i++){
	    var cursum = 0;
	    for(int j = 0;j<len0;j++){
		cursum+= arr[i,j];
	    }
	    if(cursum!=predicate) return false;
	}
	var cursumDiag = 0;
	var cursumDiagOther = 0;
	for(int i = 0; i<len0; i++){
	    cursumDiag += arr[i,i];
	    cursumDiagOther += arr[i, len0-1-i];
	}
	if(cursumDiag!=predicate) return false;
	return cursumDiagOther == predicate;
	
    } 

    public static void Main(){
	var i = Average(new int[2,2] {{3,5},{3,5}});
	Console.WriteLine(i);
    }
}
