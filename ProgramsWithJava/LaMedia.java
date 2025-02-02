import java.util.Scanner;
public class LaMedia {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
      
        double[] numbers = new double[3];

        for (int i = 0; i < 3; i++) {
            System.out.println("Introduce el numero "+ (i+1));

            numbers[i] = sc.nextDouble();
        }
        
        double result = Calculator(numbers);
        System.out.println("El resultado de la media es: " + result);
    }

    private static double Calculator (double[] numbers){
        double sum = 0;
        
        for (int i = 0; i < numbers.length; i++)
        sum = sum + numbers [i];

        return sum / numbers.length;
    }

}
