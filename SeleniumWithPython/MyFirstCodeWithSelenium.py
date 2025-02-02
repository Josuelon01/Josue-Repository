from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By
import time

chrome_driver_path = r"C:\Users\EL LOVER\Desktop\tutoria\Sepython\dchrome\chromedriver.exe";
service = Service(chrome_driver_path);

driver = webdriver.Chrome(service=service);

# Accder al navegador a la pagina de Gmail
driver.get("https://workspace.google.com/intl/es-419/gmail/");

botonAcceder = driver.find_element(By.XPATH, '//*[@id="root"]/div[1]/header/div/div[5]/a[2]');
botonAcceder.click();

# Cerrar el navegador después de un tiempo
time.sleep(5);
driver.close();

