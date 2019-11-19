#include <stdio.h>
#include <string.h>

int main()
{
	// Si lees esto, se completo exitosamente la sincronizacion
	char cadena[200];
	int indice;
	int contador = 0;
	int leyoLetras = 0;

	printf("Ingrese la cadena de caracteres: ");
	gets(cadena);

	for(indice=0; indice<strlen(cadena); indice++)
	{
		if(cadena[indice]==' ')
		{
			if(leyoLetras==1)
			{
				if(cadena[indice+1]!=' ')
					contador++;
			}
		}
		else
			leyoLetras=1;
	}

	if(cadena[indice-1]!=' ')
		contador++;

	printf("\nFrase: %s", cadena);
	printf("\nNumero de palabras: %i", contador);
	printf("\nPalabra\tCaracteres ");
	return 0;
}
