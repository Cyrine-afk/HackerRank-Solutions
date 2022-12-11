using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.ReadLine());
        
        if (T>=1 && T<=10) {
            for (int i=0; i<T; i++) {
                string S = Console.ReadLine();
                int N = S.Length;
                string S1 = "";
                string S2 = "";
                if (N>=2 && N<=10000) {
                    for (int j=0; j<N; j++) {
                        if (j==0 || j%2==0) {
                            S1+=S[j];
                        }
                    }
                    for (int j=0; j<N; j++) {
                        if (j%2!=0) {
                            S2+=S[j];
                        }
                    }
                }
                
            Console.WriteLine(S1 + " " + S2);
            }
        }
    }
}