import random

secret_number = random.randint(1, 100)

while True:
    guess = int(input("Guess the number between 1 and 100: "))
    
    if guess == secret_number:
        print("You got it. Tryhard.")
        break
    elif guess < secret_number:
        print("Too low! Nerd.")
    else:
        print("Too high! Loser.")