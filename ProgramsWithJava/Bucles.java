public class Bucles {
    
    public static void main(String[] args) {
        
        double speedCar = 0.0;
        double speedLimit = 100.0;
        int i = 0;
        while (speedCar < speedLimit) {
          
          speedCar += 12.5;
          System.out.println("El vehiculo va rapido, va a una velocidad de: " + speedCar );
        }
    }

}
