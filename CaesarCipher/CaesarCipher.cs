using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
            {
                        
                        string str= ""; 

                        for (int i=0; i<text.Length; i++) 
                        { 
                            if(char.IsLetter(text[i]))
                            {
                                if (char.IsUpper(text[i]))
                                { 
                                    char ch = (char)((text[i] + shiftKey - 65) % 26 + 65); 
                                    str += ch; 
                                } 
                                else
                                { 
                                    char ch = (char)((text[i] + shiftKey - 97) % 26 + 97); 
                                    str += ch; 
                                } 

                             }
                            else{
                                    str=str+text[i];
                                }
                        } 
                        return str; 
            } 

        public static void Main(string[] args){
            
                                             }
    }  
                
       
    
}  

        
     

