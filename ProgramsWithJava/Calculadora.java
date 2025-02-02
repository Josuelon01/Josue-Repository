import java.util.Scanner;

public class Calculadora {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Introduce el primer numero");
        Double firstNumber = sc.nextDouble();
        System.out.println("Introduce el segundo numero");
        Double secondNumber = sc.nextDouble();
        System.out.println("Introduce la funcion correspondiente 1-Suma 2-Resta 3-Multiplicacion 4-Division");
        int funcionCalculator = sc.nextInt();

        double result = doCalculation(firstNumber, secondNumber, funcionCalculator);
        
        System.out.println("El resultado de la operacion " + funcionCalculator + " es: " + result);
    }
      
    private static double doCalculation (double firstNumber, double secondNumber, int funcionCalculator) {
        if (funcionCalculator == 1) {
            return Sum(firstNumber, secondNumber);
        } else if (funcionCalculator == 2) {
            return Resta(firstNumber, secondNumber);
        } else if (funcionCalculator == 3) {
            return Multiplicacion(firstNumber, secondNumber);
        } else if (funcionCalculator == 4) {
            return Division(firstNumber, secondNumber);
        } else {
            throw new IllegalStateException("Operación no válida. Debe ser un número entre 1 y 4."); 
        }
    
    }
    private static double Sum(double firstNumber, double secondNumber) {
        return firstNumber + secondNumber;
    }
    private static double Resta(double firstNumber, double secondNumber) {
        return firstNumber - secondNumber;
    }
    private static double Multiplicacion(double firstNumber, double secondNumber) {
        return firstNumber * secondNumber;
    }
    private static double Division(double firstNumber, double secondNumber) {
        return firstNumber / secondNumber;
    }
    // Funcion descartada, solo para tenerla en qiut//
    private static void operacionNoValida(int funcionCalculator) {
        if (funcionCalculator < 1 || funcionCalculator > 4) {
            System.out.println("Operación no válida. Debe ser un número entre 1 y 4.");
        }
    }

}

