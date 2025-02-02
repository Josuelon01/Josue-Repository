import java.util.Scanner;

public class PrimerEstructura {

    public static void main(String[] args){
        
    Scanner sc = new Scanner(System.in);
    System.out.println("Seleccione la categoria que desea saber el impuesto");
    String productType = sc.next(); 

    switch (productType) {
        case "Salud":
        System.out.println("El impuesto es 5%");
            break;
        case "Belleza":
        System.out.println("El impuesto es 10%");
            break;
        case "Nutricion":
        System.out.println("El impuesto es 15%"); 
            break;

        default:
        System.out.println("El producto es desconocido");
            break;
        }
    }
}
