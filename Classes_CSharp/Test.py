

def SummNumbersInRange(num):
	result = 0
	for i in range(1, num):
		result += i
	return result

class Country(object):
	def __init__(self, name, code):
		self.name = name
		self.code = code

country_list = []

china = Country("China", 4544)
morroco = Country("Marocco", 13748)
spain = Country("Spain", 6452)
usa = Country("USA", 3774)
brasil = Country("Brasil", 1587)

country_list.append(china)
country_list.append(morroco)
country_list.append(spain)
country_list.append(usa)
country_list.append(brasil)





