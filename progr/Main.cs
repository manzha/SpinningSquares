using System;
using System.Collections.Generic;

namespace prueba3
{
	class MainClass
	{
		public static int[] board = { 2, 5, 1, 8, 3, 7, 9, 4, 6 };
		public static void Main (string[] args)
		{

			String[] moves={ "A", "B", "C", "D" };
			String aux;
			List<string> solutions = new List<string>();
			for(int i = 0;i < moves.Length; i++){
				solutions.Add( moves[i] );
				
			}
						
			do {
				aux = solutions[0];
				solutions.RemoveAt(0);
				if(solucion(aux)){
					Console.WriteLine( "Si tiene solucion con"+aux );
					break;
				}
				for(int i = 0;i < moves.Length; i++){
					solutions.Add( aux + moves[i] );
					
				}
			} while(true);

			
			foreach (string solutionsMoves in solutions)
			{
				Console.WriteLine( solutionsMoves );
			}
			
		}

		private static bool solucion(String aux){
			int i = 0, aux1,aux2,aux3,aux4;
			for(i=0;i<aux.Length;i++){
				if(aux[i].Equals("A")){
					aux1 = board[0];
					aux2 = board[1];
					aux3 = board[3];
					aux4 = board[4];

					board[0] = aux3;
					board[1] = aux1;
					board[3] = aux4;
					board[4] = aux2;
				}else{
					if(aux[i].Equals("B")){
						aux1 = board[1];
						aux2 = board[2];
						aux3 = board[4];
						aux4 = board[5];
						
						board[1] = aux3;
						board[2] = aux1;
						board[4] = aux4;
						board[5] = aux2;
					}else{
						if(aux[i].Equals("C")){
							aux1 = board[3];
							aux2 = board[4];
							aux3 = board[6];
							aux4 = board[7];
							
							board[3] = aux3;
							board[4] = aux1;
							board[6] = aux4;
							board[7] = aux2;
						}else{
							if(aux[i].Equals("D")){
								aux1 = board[4];
								aux2 = board[5];
								aux3 = board[7];
								aux4 = board[8];
								
								board[4] = aux3;
								board[5] = aux1;
								board[7] = aux4;
								board[8] = aux2;
							}
						}
					}
			}//Fin del else
			}
			if(board[0]==1 && board[1]==2 && board[2]==3 && board[3]==4 && board[4]==5 && board[5]==6
				   && board[6]==7 && board[7]==8 && board[8]==9){
					return true;
				}else{
					return false;
				}
		
	}
}
}
