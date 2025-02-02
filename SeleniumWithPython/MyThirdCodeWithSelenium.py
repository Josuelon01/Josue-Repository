from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
import time

chromeDriver = r"C:\Users\EL LOVER\Desktop\tutoria\Sepython\dchrome\chromedriver.exe";
service = Service(chromeDriver)
driver = webdriver.Chrome(service=service)

wait = WebDriverWait(driver, 5)

driver.get("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login")

userField = wait.until(EC.presence_of_element_located((By.NAME, "username")))
userField.click()
userField.send_keys("Admin")
time.sleep(2)

passwordField = wait.until(EC.presence_of_element_located((By.NAME, "password")))
passwordField.click()
passwordField.send_keys("admin123")

button = driver.find_element(By.XPATH, "//*[@id='app']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button")
button.click()
time.sleep(2)

adminButton = wait.until(EC.presence_of_element_located((By.XPATH, "//*[@id='app']/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a")))
adminButton.click()
time.sleep(2)

searchField = wait.until(EC.presence_of_element_located((By.XPATH, "//*[@id='app']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input")))
searchField.click()
searchField.send_keys("Admin")
time.sleep(5)

searchButton = driver.find_element(By.XPATH, "//*[@id='app']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")
searchButton.click()
time.sleep(2)

addButton = driver.find_element(By.XPATH, "//*[@id='app']/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[2]/div/div/div[6]/div/button[2]/i")
addButton.click()
time.sleep(2)

editUsernameField = driver.find_element(By.XPATH, "//*[@id='app']/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input")
editUsernameField.click()
editUsernameField.send_keys("123")