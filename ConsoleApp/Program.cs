using System;
using Aliyun.Net.SDK.Core;
using Aliyun.Net.SDK.Core.Exceptions;
using Aliyun.Net.SDK.Core.Profile;
using Aliyun.Acs.Dysmsapi.Model.V20170525;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String product = "Dysmsapi";//短信API产品名称
            String domain = "dysmsapi.aliyuncs.com";//短信API产品域名
            String accessKeyId = "xxxx";//你的accessKeyId
            String accessKeySecret = "xxxxx";//你的accessKeySecret

            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", accessKeyId, accessKeySecret);
            //IAcsClient client = new DefaultAcsClient(profile);
            // SingleSendSmsRequest request = new SingleSendSmsRequest();

            DefaultProfile.AddEndpoint("cn-hangzhou", "cn-hangzhou", product, domain);
            IAcsClient acsClient = new DefaultAcsClient(profile);
            SendSmsRequest request = new SendSmsRequest();
            try
            {
                //必填:待发送手机号。支持以逗号分隔的形式进行批量调用，批量上限为20个手机号码,批量调用相对于单条调用及时性稍有延迟,验证码类型的短信推荐使用单条调用的方式
                request.PhoneNumbers = "xxxxxx";  //测试手机 landp
                //必填:短信签名-可在短信控制台中找到
                request.SignName = "思柯瑞";  // 思柯瑞
                //必填:短信模板-可在短信控制台中找到
                request.TemplateCode = "SMS_85880010";   // 锦江水质监测平台 - 用户注册验证码
                                                         //可选:模板中的变量替换JSON串,如模板内容为模版内容:    验证码${code}，您正在注册成为新用户，感谢您的支持！

                request.TemplateParam = "{\"code\":\"8888\"}";
                //可选:outId为提供给业务方扩展字段,最终在短信回执消息中将此值带回给调用者
                request.OutId = "21212121211";
                //请求失败这里会抛ClientException异常
                SendSmsResponse sendSmsResponse = acsClient.GetAcsResponse(request);

                System.Console.WriteLine(sendSmsResponse.Message);
            }
            catch (ServerException e)
            {
                System.Console.WriteLine("Hello World!");
            }
            catch (ClientException e)
            {
                System.Console.WriteLine("Hello World!");
            }
        }
    }
}