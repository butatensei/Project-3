fileIn1 = 'KNMI_20131231.csv'
fileOut1 = 'FixedThatForYou.csv'
column1 = 1
column2 = 0
KNMI = False

weatherStations = 'Weerstations.csv'


import csv


if KNMI:
    with open(weatherStations) as csvweatherStations:
        weatherReader = csv.reader(csvweatherStations)
        for row in weatherReader:
            if row[0] == row2[0]:
                row[0] = row2[4]

with open(fileIn1) as csvfileIn1:
    
    csvfileIn1.seek(0)
    reader = csv.reader(csvfileIn1)



    for row in reader:

        if row[column1][2] == "/":
            row[column1] = row[column1].replace("/", "")
            date = [row[column1][:2], row[column1][2:4], row[column1][4:]]
        else:
            date = [row[column1][:4], row[column1][4:6], row[column1][6:]]
        row = row[:(column1-1)] + date + row[(column1+1):]



        print(row)

        with open(fileOut1, 'a',  newline='') as csvfileOut1:
            writer = csv.writer(csvfileOut1)
            writer.writerow(row)