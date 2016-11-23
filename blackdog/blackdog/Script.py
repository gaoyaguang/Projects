#encoding:utf-8
'''
Created on 2016年11月22日

@author: xmcx
'''
import urllib

def posts(param):
    #定义一个要提交的数据数组(字典)
    data = {}
#     data['req'] = '[{"mobileNumber":"15811347006","password":"00B7691D86D96AEBD21DD9E138F90840","loginDeviceId":"B804D325-0EAE-4CBF-BFB4-804407C84488","isManual":"1"}]'
    data['req'] = param
    #定义post的地址
    url = 'http://www.heigo.com.cn/map-web/servlet/Login2Servlet'
    post_data = urllib.urlencode(data)
    #提交，发送数据
    req = urllib2.urlopen(url, post_data)
    #获取提交后返回的信息
    content = req.read()
    return content
print posts('[{"mobileNumber":"15811347006","password":"00B7691D86D96AEBD21DD9E138F90840","loginDeviceId":"B804D325-0EAE-4CBF-BFB4-804407C84488","isManual":"1"}]')







