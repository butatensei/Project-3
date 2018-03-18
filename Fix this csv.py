fileIn1 = 'KNMI_20180316_hourly.csv'
fileOut1 = 'FixedThatForYou.csv'
column1 = 1
column2 = 0
KNMI = True

import csv

stationDict = {}
typeDict = {}
weatherStations = 'Weerstations.csv'
columnTypes = 'Kolommen.csv'
with open(weatherStations) as csvweatherStations:
    with open(columnTypes) as csvcolumnTypes:
        weatherReader = csv.reader(csvweatherStations)
        typeReader = csv.reader(csvcolumnTypes)
        for row in weatherReader:
            stationDict[row[0]] = row[4]
        for row in typeReader:
            typeDict[row[0]] = row[1]

        with open(fileIn1) as csvfileIn1:

            csvfileIn1.seek(0)
            reader = csv.reader(csvfileIn1)

            for row in reader:

                if row[column1][2] == "/":
                    row[column1] = row[column1].replace("/", "")
                    date = [row[column1][:2], row[column1][2:4], row[column1][4:]]
                else:
                    date = [row[column1][:4], row[column1][4:6], row[column1][6:]]
                row = row[:column1] + date + row[(column1+1):]
                for i in range(len(row)):
                    row[i] = row[i].strip(" ")
                for i in range(len(row)):
                    if row[i] in typeDict:
                        row[i] = typeDict[row[i]]
                if row[0] in stationDict:
                    row[0] = stationDict[row[0]]

                print(row)

                with open(fileOut1, 'a',  newline='') as csvfileOut1:
                    writer = csv.writer(csvfileOut1)
                    writer.writerow(row)