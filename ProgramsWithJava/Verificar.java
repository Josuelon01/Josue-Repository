import java.util.Scanner;

public class verificar {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite su numero por favor");
        float theNumber = sc.nextFloat();

        if (theNumber % 1 == 0) {
            System.out.println("Este numero es entero."); 
        }
        else { 
            System.out.println("Este numero es decimal."); 
        }
    }   
}
