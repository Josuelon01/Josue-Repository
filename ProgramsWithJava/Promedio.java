import java.util.Scanner;

public class promedio {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Cuantos numeros desea ingresar");
        int cantidad = sc.nextInt(); 

        double suma = 0;
        double maximo = Double.MIN_VALUE;
        double minimo = Double.MAX_VALUE;

        for (int i = 1; i <= cantidad; i++) {
            
            System.out.println("Ingresa el numero " + i + " :");
            Double numero = sc.nextDouble();

            suma += numero;

            if (numero < maximo) {
                maximo = numero;
            } if (numero < minimo) {
                minimo = numero;
            }
        }

        double promedio = suma / cantidad;

        System.out.println("El promedio de numeros es: "+promedio);
        System.out.println("El numero maximo es: "+maximo);
        System.out.println("El numero minimo es: "+minimo);

        sc.close();
    }

}
