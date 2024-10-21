
using System;
class VoilaUniverse {
	public static int[] Doer(int[] arr) {
		Console.WriteLine($"ip:<{string.Join(",",arr)}>");
		int count=arr.Length;
		if(count==0) {
			return new int[] {1};
		}
		arr[count-1]+=1;
		if(arr[count-1]<10) {
			return arr;
		}
		for(int i=count-1; i>0; i--) {
			if(arr[i]==10) {
				arr[i]=0;
				arr[i-1]+=1;
				continue;
			} else {
				break;
			}
		}
		if(arr[0]==10) {
			int[] temp=new int[count+1];
			temp[0]=1;
			return temp;
		}
		return arr;
	}
	public static int[] arr;
	public static int[] op;
	static void Main() {
		arr=new int[] {};
		op=Doer(arr);
		Console.WriteLine($"op:<{string.Join(",",op)}>");
		arr=new int[] {1};
		op=Doer(arr);
		Console.WriteLine($"op:<{string.Join(",",op)}>");
		arr=new int[] {9};
		op=Doer(arr);
		Console.WriteLine($"op:<{string.Join(",",op)}>");
		arr=new int[] {1,5};
		op=Doer(arr);
		Console.WriteLine($"op:<{string.Join(",",op)}>");
		arr=new int[] {1,9};
		op=Doer(arr);
		Console.WriteLine($"op:<{string.Join(",",op)}>");
		arr=new int[] {9,0,9};
		op=Doer(arr);
		Console.WriteLine($"op:<{string.Join(",",op)}>");
		arr=new int[] {9,9,9};
		op=Doer(arr);
		Console.WriteLine($"op:<{string.Join(",",op)}>");
	}
}
