Module Module1
    'Stats
    Dim health As Integer = 100
    Dim mana As Integer = 200
    Dim physicaldmg As Integer = 4
    Dim magicaldmg As Integer = 6
    'Fight
    Dim enemy As String = "spider"
    Dim c_enemy As String = "Spider"
    Dim enemydmg As Integer = 1
    Dim enemyhp As Integer = 10
    Dim rng As New Random
    Dim min_enemy_dmg As Integer = 1
    Dim max_enemy_dmg As Integer = 3
    'Choices
    Dim fightchoice As Integer = 0
    Dim gift As Integer = 0
    Dim leftright As Integer = 0
    Dim left As Integer = 0
    Dim leftright2 As Integer = 0
    'Fluff
    Dim anykey As ConsoleKeyInfo
    Dim story As String
    'Useful repeated code
    '("<------------------------------------>")
    'console.resetcolor()
    '("<------->")
    'Console.WriteLine("Press any key to cotinue...")
    'anykey = Console.ReadKey()
    Public Sub StoryLine()
        Console.Clear()
        'Defense
        Console.WriteLine("<------->")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("HP: " & health)
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("Mana: " & mana)
        Console.ResetColor()
        Console.WriteLine("<------->")
        'Attack
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine("Physical Damage: " & physicaldmg)
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("Magical Damage: " & magicaldmg)
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkGray
        Console.WriteLine("<------------------------------------>")
        Console.WriteLine(story)
        Console.WriteLine("<------------------------------------>")
        Console.ResetColor()
    End Sub
    Public Sub StoryNoLine()
        Console.Clear()
        'Defense
        Console.WriteLine("<------->")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("HP: " & health)
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("Mana: " & mana)
        Console.ResetColor()
        Console.WriteLine("<------->")
        'Attack
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine("Physical Damage: " & physicaldmg)
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("Magical Damage: " & magicaldmg)
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkGray
        Console.WriteLine("<------------------------------------>")
        Console.WriteLine(story)

    End Sub
    Public Sub Fight()
        fightchoice = 0
        Do Until fightchoice = 1 Or fightchoice = 2 Or fightchoice = 3 Or health <= 0 Or enemyhp <= 0
            Console.Clear()
            For i As Integer = 1 To 1
                enemydmg = rng.Next(min_enemy_dmg, max_enemy_dmg)
            Next
            health -= enemydmg
            If health <= 0 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("HP: {0}", health)
                Console.WriteLine("The {0} did {1} damage!", enemy, enemydmg)
                Console.WriteLine("You were slain by a {0}!", enemy)
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("Ending in 3...")
                System.Threading.Thread.Sleep(1000)
                Console.WriteLine("2...")
                System.Threading.Thread.Sleep(1000)
                Console.WriteLine("1...")
                System.Threading.Thread.Sleep(1000)
                End
            Else
                Console.Clear()
                'Defense Stats
                Console.WriteLine("<------->")
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("HP: " & health)
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine("Mana: " & mana)
                Console.ResetColor()
                Console.WriteLine("<------->")
                'Attack Stats
                Console.ForegroundColor = ConsoleColor.DarkRed
                Console.WriteLine("Physical Damage: " & physicaldmg)
                Console.ForegroundColor = ConsoleColor.DarkBlue
                Console.WriteLine("Magical Damage: " & magicaldmg)
                Console.ResetColor()
                Console.WriteLine("<------->")
                'Enemy Stats
                Console.WriteLine("You encounter a {0}!", enemy)
                Console.ForegroundColor = ConsoleColor.DarkGray
                Console.WriteLine("<------------------------------------>")
                Console.WriteLine("The {0} attacks for {1} damage!", enemy, enemydmg)
                Console.WriteLine("{0} HP: {1}", c_enemy, enemyhp)
                Console.WriteLine("<------------------------------------>")
                Console.ResetColor()
                'Fight Choice
                Console.WriteLine("1: Physical attack")
                Console.WriteLine("2: Enchanted physical attack (2x physical dmg / -100 mana)")
                Console.WriteLine("3: Magical attack (-50 mana)")
                Console.WriteLine("")
                fightchoice = Console.ReadLine
                Console.WriteLine("")
                Select Case fightchoice
                    Case = 1
                        enemyhp -= physicaldmg
                        Console.WriteLine("You hit the {0}; doing {1} damage!", enemy, physicaldmg)
                        Console.WriteLine("Press any key to cotinue...")
                        anykey = Console.ReadKey()
                        fightchoice = 0
                    Case = 2
                        If mana < 100 Then
                            Console.WriteLine("You attempt to enchant your attack with insufficienct mana; forfeiting your turn!")
                            fightchoice = 0
                            Console.WriteLine("Press any key to cotinue...")
                            anykey = Console.ReadKey()
                        Else
                            enemyhp -= physicaldmg * 2
                            mana -= 100
                            Console.WriteLine("You hit the {0}; doing {1} damage!", enemy, physicaldmg * 2)
                            Console.WriteLine("Press any key to cotinue...")
                            anykey = Console.ReadKey()
                            fightchoice = 0
                        End If
                    Case = 3
                        If mana < 50 Then
                            Console.WriteLine("You attempt to cast a spell with insufficienct mana; forfeiting your turn!")
                            fightchoice = 0
                            Console.WriteLine("Press any key to cotinue...")
                            anykey = Console.ReadKey()
                        Else
                            enemyhp -= magicaldmg
                            mana -= 50
                            Console.WriteLine("You shock the {0}; doing {1} damage!", enemy, magicaldmg)
                            Console.WriteLine("Press and key to cotinue...")
                            anykey = Console.ReadKey()
                            fightchoice = 0
                        End If
                End Select
            End If
        Loop
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("You have slain the {0}.", enemy)
        Console.ResetColor()
        Console.WriteLine("Press any key to cotinue...")
        anykey = Console.ReadKey()
    End Sub
    Public Sub Gifts()
        Do Until gift = 1 Or gift = 2 Or gift = 3 Or gift = 4
            Console.Clear()
            'Defense Stats
            Console.WriteLine("<------->")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("HP: " & health)
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("Mana: " & mana)
            Console.ResetColor()
            Console.WriteLine("<------->")
            'Attack Stats
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Physical Damage: " & physicaldmg)
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.WriteLine("Magical Damage: " & magicaldmg)
            Console.ResetColor()
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("<------------------------------------>")
            Console.WriteLine(story)
            Console.WriteLine("He says he gives gifts.")
            Console.WriteLine("<------------------------------------>")
            Console.ResetColor()
            'Fight Choice
            Console.WriteLine("1: Strength")
            Console.WriteLine("2: Power")
            Console.WriteLine("3: Resilience")
            Console.WriteLine("4: Wisdom")
            Console.WriteLine("5: Destuction")
            Console.WriteLine("")
            gift = Console.ReadLine
            Console.WriteLine("")
            Select Case gift
                Case = 1
                    Console.WriteLine("He gives you a dull steel sword. (+3 physical damage)")
                    physicaldmg += 3
                Case = 2
                    Console.WriteLine("He gives you a tome filled with strange symbols. (+5 magical damage)")
                    magicaldmg += 5
                Case = 3
                    Console.WriteLine("He gives you a strange red potion. (+50 health)")
                    health += 50
                Case = 4
                    Console.WriteLine("He gives you a strange blue potion. (+400 mana)")
                    mana += 400
                Case = 5
                    health = 0
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("HP: {0}", health)
                    Console.WriteLine("The man vaporizes you; gift granted.")
                    System.Threading.Thread.Sleep(3000)
                    Console.WriteLine("Ending in 3...")
                    System.Threading.Thread.Sleep(1000)
                    Console.WriteLine("2...")
                    System.Threading.Thread.Sleep(1000)
                    Console.WriteLine("1...")
                    System.Threading.Thread.Sleep(1000)
                    End
            End Select
        Loop
        Console.WriteLine("Press any key to cotinue...")
        anykey = Console.ReadKey()
    End Sub
    Public Sub Left_Right()
        fightchoice = 0
        Do Until leftright = 1

            Console.Clear()
            'Defense Stats
            Console.WriteLine("<------->")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("HP: " & health)
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("Mana: " & mana)
            Console.ResetColor()
            Console.WriteLine("<------->")
            'Attack Stats
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Physical Damage: " & physicaldmg)
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.WriteLine("Magical Damage: " & magicaldmg)
            Console.ResetColor()
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("<------------------------------------>")
            Console.WriteLine("You continue down the path. Which way do you go?")
            Console.WriteLine("<------------------------------------>")
            Console.ResetColor()
            'Path Choice
            Console.WriteLine("1: Left")
            Console.WriteLine("2: Right")
            Console.WriteLine("")
            leftright = Console.ReadLine
            Console.WriteLine("")
            Select Case leftright
                Case = 1
                    If left = 0 Then
                        story = "You go the correct way; leading to another split path."
                        left = 1
                    Else
                        story = "You go left again; another split..."
                    End If
                    StoryLine()
                    Console.WriteLine("Press any key to cotinue...")
                    anykey = Console.ReadKey()
                Case = 2
                    Fight()
                    story = "You went the wrong way, and decide to head back."
                    StoryLine()
                    Console.WriteLine("Press any key to cotinue...")
                    anykey = Console.ReadKey()
                    fightchoice = 0
            End Select
        Loop
    End Sub
    Public Sub Left_Right2()
        fightchoice = 0
        Do Until leftright2 = 2

            Console.Clear()
            'Defense Stats
            Console.WriteLine("<------->")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("HP: " & health)
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("Mana: " & mana)
            Console.ResetColor()
            Console.WriteLine("<------->")
            'Attack Stats
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Physical Damage: " & physicaldmg)
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.WriteLine("Magical Damage: " & magicaldmg)
            Console.ResetColor()
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("<------------------------------------>")
            Console.WriteLine("You continue down the path. Which way do you go?")
            Console.WriteLine("<------------------------------------>")
            Console.ResetColor()
            'Path Choice
            Console.WriteLine("1: Left")
            Console.WriteLine("2: Right")
            Console.WriteLine("")
            leftright2 = Console.ReadLine
            Console.WriteLine("")
            Select Case leftright2
                Case = 2
                    story = "You go the correct way; leading to the exit of the cave."

                    StoryLine()
                    Console.WriteLine("Press any key to cotinue...")
                    anykey = Console.ReadKey()
                Case = 1
                    Fight()
                    story = "You went the wrong way, and decide to head back."
                    StoryLine()
                    Console.WriteLine("Press any key to cotinue...")
                    anykey = Console.ReadKey()
                    fightchoice = 0
            End Select
        Loop
    End Sub
    Sub Main()
        'Start
        story = "You awake in a dark cave. You see a small light and begin heading towards it."
        StoryLine()
        Console.WriteLine("Any option can be selected by typing the number in front of the selection and pressing enter.")
        Console.WriteLine("Press any key to cotinue...")
        anykey = Console.ReadKey()
        'Spider fight
        Fight()
        'Gift
        story = "You get to the souce of the light; revealing an old, wise-looking man."
        StoryNoLine()
        Console.WriteLine("He says he gives gifts.")
        Console.WriteLine("<------------------------------------>")
        Console.ResetColor()
        Gifts()
        'Directions
        story = "The man gives you directions to the exit. Left-left-right. You head towards where he directed."
        StoryLine()
        Console.WriteLine("Press any key to cotinue...")
        anykey = Console.ReadKey()
        'Bat fight
        enemy = "giant bat"
        c_enemy = "Giant bat"
        enemyhp = 15
        min_enemy_dmg = 6
        max_enemy_dmg = 11
        Fight()
        'First left/right
        enemy = "snake"
        c_enemy = "Snake"
        enemyhp = 15
        min_enemy_dmg = 12
        max_enemy_dmg = 17
        Left_Right()
        'Second left/right
        leftright = 0
        enemy = "skeleton"
        c_enemy = "Skeleton"
        enemyhp = 20
        min_enemy_dmg = 14
        max_enemy_dmg = 18
        Left_Right()
        'Third right/left
        enemy = "vampire"
        c_enemy = "Vampire"
        enemyhp = 5
        min_enemy_dmg = 20
        max_enemy_dmg = 31
        Left_Right2()
        'Golem fight
        story = "You see light; you are almost out."
        StoryNoLine()
        Console.WriteLine("There is a golem blocking the exit!")
        Console.WriteLine("<------------------------------------>")
        Console.ResetColor()
        Console.WriteLine("Press any key to cotinue...")
        anykey = Console.ReadKey()
        enemy = "golem"
        c_enemy = "Golem"
        enemyhp = 40
        min_enemy_dmg = 10
        max_enemy_dmg = 16
        Fight()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("You win!")
        System.Threading.Thread.Sleep(3000)
        Console.WriteLine("Ending in 3...")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("2...")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("1...")
        System.Threading.Thread.Sleep(1000)
        End
    End Sub
End Module
