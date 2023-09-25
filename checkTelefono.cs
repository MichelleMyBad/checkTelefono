using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        string numero="";
        for(int i=0; i<input.Length; i++ ){   
            numero=input[i];
            if((numero.Length==14&&numero.Substring(0,5)=="00393")||(numero.Length==10&&numero[0]=='3')||(numero.Length==13&&numero.Substring(0,4)=="+393"))
                if(CheckClean(input[i]))
                    return input[i];        
        }
        return "";
    }

    public static bool CheckClean(string numero){
    for(int i=1; i<numero.Length; i++ )
        if(char.IsDigit(numero[i])==false)
            return false;

    return true;
    }


}