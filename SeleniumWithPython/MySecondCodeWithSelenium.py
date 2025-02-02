from selenium import webdriver;
from selenium.webdriver.chrome.service import Service;
from selenium.webdriver.common.by import By;
from selenium.webdriver.common.keys import Keys;
import time;

chromeDriver = r"C:\Users\EL LOVER\Desktop\tutoria\Sepython\dchrome\chromedriver.exe";
service = Service(chromeDriver);
driver = webdriver.Chrome(service=service);

# Acceder a la pagina de Nike
driver.get("https://www.nike.com/es/");

search = driver.find_element(By.CLASS_NAME, "search-start-icon-container");
search.click();

searchField = driver.find_element(By.ID, "gn-search-input");
searchField.send_keys("Air Max");
searchField.send_keys(Keys.RETURN);  # Presionar Enter para realizar la búsqueda

# Esperar unos segundos para observar el resultado (opcional), luego cerrar.
time.sleep(5);
driver.close();
