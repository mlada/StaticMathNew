namespace ClassLibrary1
{
    public class Element
    {
        public int value;
        public int index;
        public Element(int v, int i)
        {
            value = v; index = i;
        }
        
    }
    public class Class1
    {

        public static int Func1(int[] a, int[] b){
            int res = 1;
            if (a.Length > 0)  
                for (int i = 0; i < a.Length; ++i){
                    if (a[i] != 0)
                        for (int j = 0; j < b.Length; ++j){
                            if (b[j] == i)
                                res *= a[i];
                        }
                }
            else
                res = 0;
            return res;
        }

        public static Element Func2(int[] a)
        {
            Element el = new Element(a[0],0);
            for (int i = 0; i < a.Length; ++i){
                if (a[i] <= el.value)                
                    el.value = a[i];
                    el.index = i;                
            }
            return el;
        }

        public static double[] Func3(double[] a)
        {
            double[] b = a;
            Array.Reverse(b);
            return b;
        }
    }
}
