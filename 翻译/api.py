import http.client
import hashlib
import os
import time
import urllib
import random
import json
import argparse

appid = '20200211000382774'
secretKey = 'b1imCNk_EdXIHM0zX2bD' 

httpClient = None
myurl = '/api/trans/vip/translate'

fromLang = 'auto'
salt = random.randint(32768, 65536)

parser = argparse.ArgumentParser()
parser.add_argument("text", type=str, help="Input text")
parser.add_argument("lang", type=str, help="""Language:
    zh  中文\n
    en  英语\n
    yue 粤语\n
    wyw 文言文\n

    jp  日语\n
    kor 韩语\n
    fra 法语\n
    spa 西班牙语\n

    th  泰语\n
    ara 阿拉伯语\n
    ru  俄语\n
    pt  葡萄牙语\n

    de  德语\n
    it  意大利语\n
    el  希腊语\n
    nl  荷兰语\n

    pl  波兰语\n
    bul 保加利亚语\n
    est 爱沙尼亚语\n
    dan 丹麦语\n

    fin 芬兰语\n
    cs  捷克语\n
    rom 罗马尼亚语\n
    slo 斯洛文尼亚语\n

    swe 瑞典语\n
    hu  匈牙利语\n
    cht 繁体中文\n
    vie 越南语\n
""")
args = parser.parse_args()
toLang = args.lang
q = args.text
sign = appid + q + str(salt) + secretKey
sign = hashlib.md5(sign.encode()).hexdigest()
myurl = myurl + '?appid=' + appid + '&q=' + urllib.parse.quote(q) + '&from=' + fromLang + \
        '&to=' + toLang + '&salt=' + str(salt) + '&sign=' + sign

try:
    httpClient = http.client.HTTPConnection('api.fanyi.baidu.com')
    httpClient.request('GET', myurl)
    response = httpClient.getresponse()
    result_all = response.read().decode("utf-8")
    result = json.loads(result_all)
    returned = result['trans_result'][0]['dst']
    print(returned)

except Exception as e:
    print (e)
finally:
    if httpClient:
        httpClient.close()
