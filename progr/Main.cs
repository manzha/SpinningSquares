using System;
using System.Collections.Generic;

namespace prueba3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] board = { 2, 5, 1, 8, 3, 7, 9, 4, 6 };
			String[] moves={ "A", "B", "C", "D" };

			List<string> solutions = new List<string>();
			for(int i = 0;i < moves.Length; i++){
				solutions.Add( moves[i] );

			}

			for(int i = 0;i < moves.Length; i++){
				for(int j = 0;j < moves.Length; j++){
					solutions.Add( moves[i]+moves[j] );
					
				}
				
			}

			for(int i = 0;i < moves.Length; i++){
				for(int j = 0;j < moves.Length; j++){
					for(int k = 0;k < moves.Length; k++){
						solutions.Add( moves[i]+moves[j] +moves[k]);
						
					}
					
				}
				
			}

			for(int i = 0;i < moves.Length; i++){
				for(int j = 0;j < moves.Length; j++){
					for(int k = 0;k < moves.Length; k++){
						for(int l = 0;l < moves.Length; l++){
							if((i!=i)||(k!=i)||(j!=i)||(l!=i)){
								solutions.Add( moves[i]+moves[j] +moves[k]+moves[l]);


							}
						}
						
					}
					
				}
				
			}






			foreach (string solutionsMoves in solutions)
			{
				Console.WriteLine( solutionsMoves );
			}

		}
	}
}
