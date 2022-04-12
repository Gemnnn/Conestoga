#!/user/bin/python3
# Assignment5_3
# Byounguk Min 
# Question 3
# Make a two-player Rock-Paper-Scissors game

firstPlayer = input("Enter rock/paper/scissors of Player 1: ")
secondPlayer = input("Enter rock/paper/scissors of Player 2: ")

def rock_paper_scissors(player1, player2):
    list = ["rock", "paper", "scissors"]

    while player1 not in list or player2 not in list:
        print ("Invalid input, Please give a valid input.")
        player1 = input("Enter rock/paper/scissors of Player 1: ")
        player2 = input("Enter rock/paper/scissors of Player 2: ")

    while player1 == player2:
        print ("No win, Try again")
        player1 = input("Enter rock/paper/scissors of Player 1: ")
        player2 = input("Enter rock/paper/scissors of Player 2: ")

    if player1 == "rock" and player2 == "paper":
        print ("Player 2 wins!")

    elif player1 == "paper" and player2 == "rock":
        print ("Player 1 wins!")

    elif player1 == "rock" and player2 == "scissors":
        print ("Player 1 wins!")

    elif player1 == "scissors" and player2 == "rock":
        print ("Player 2 wins")

    elif player1 == "paper" and player2 == "scissors":
        print ("Player 2 wins!")

    elif player1 == "scissors" and player2 == "paper":
        print ("Player 1 wins!")

rock_paper_scissors(firstPlayer, secondPlayer)