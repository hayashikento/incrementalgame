import json
from collections import OrderedDict
import pprint

s = r'{"Features":[{"revenue":20000.0,"rps":0.0,"hamLevel":0,"BhamLevel":0,"ChamLevel":0,"ShamLevel":0,"WChamLevel":0,"EhamLevel":0,"ITLevel":0,"AMLevel":0,"CMLevel":0,"NSLevel":0,"SNSLevel":0,"ham":true,"Bham":true,"Sham":false,"Cham":false,"WCham":false,"Eham":false,"IT":true,"AM":true,"CM":true,"NS":false,"action":0},{"revenue":16968.057928,"rps":130.0,"hamLevel":1,"BhamLevel":0,"ChamLevel":0,"ShamLevel":0,"WChamLevel":0,"EhamLevel":0,"ITLevel":0,"AMLevel":0,"CMLevel":0,"NSLevel":0,"SNSLevel":0,"ham":true,"Bham":true,"Sham":false,"Cham":false,"WCham":false,"Eham":false,"IT":false,"AM":false,"CM":true,"NS":false,"action":1}]}
print(s)

d = json.loads(s)