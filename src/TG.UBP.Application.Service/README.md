﻿应用层
应用层提供一些应用服务（Application Services）方法供展现层调用。一个应用服务方法接收一个DTO(数据传输对象)作为输入参数，使用这个输入参数执行特定的领域层操作，并根据需要可返回另一个DTO。在展现层到领域层之间，不应该接收或返回实体(Entity)对象，应该进行DTO映射。一个应用服务方法通常被认为是一个工作单元（Unit of Work）。用户输入参数的验证工作也应该在应用层实现。ABP提供了一个基础架构让我们很容易地实现输入参数有效性验证。使用AutoMapper来进行实体与DTO之间的映射。

具体规则：
1、应用层主要包括三个内容：
	服务接口
	服务类
	Dto
	......
2、按模块+功能建立子目录，例如：BaseManage（基础管理）\User（用户管理）；
3、在子目录下创建相应的服务接口、服务类和Dto目录；
4、在Dto目录下创建需要的Dto类；
5、在服务类中要完成对Dto的数据验证；