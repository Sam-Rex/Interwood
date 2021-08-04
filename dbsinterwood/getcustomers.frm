TYPE=VIEW
query=select `dbsinterwood`.`customers`.`custId` AS `معرف العميل`,concat(`dbsinterwood`.`customers`.`fName`,\' \',`dbsinterwood`.`customers`.`midNName`,\' \',`dbsinterwood`.`customers`.`lName`) AS `اسم العميل`,`dbsinterwood`.`customers`.`phoneNo` AS `رقم الهاتف`,`dbsinterwood`.`customers`.`address` AS `العنوان`,`dbsinterwood`.`customers`.`eMail` AS `البريد الإلكتروني`,`dbsinterwood`.`cities`.`cityName` AS `المدينة الحالية`,`dbsinterwood`.`customers`.`accId` AS `رقم الحساب` from (`dbsinterwood`.`customers` join `dbsinterwood`.`cities` on((`dbsinterwood`.`customers`.`cityId` = `dbsinterwood`.`cities`.`cityId`))) where (`dbsinterwood`.`customers`.`cityId` = `dbsinterwood`.`cities`.`cityId`)
md5=ae7db71cf2ab5f93b64b07b5cb8d0e97
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2018-12-03 04:06:46
create-version=1
source=SELECT `custId`\'معرف العميل\', concat( `fName`,\' \',`midNName`,\' \', `lName`)\'اسم العميل\',\n    `phoneNo`\'رقم الهاتف\',`address`\'العنوان\',`eMail`\'البريد الإلكتروني\',`cities`.`cityName`\'المدينة الحالية\',`accId`\'رقم الحساب\'\nFROM `dbsinterwood`.`customers` inner join `dbsinterwood`.`cities` on customers.`cityId` = cities.cityId where `customers`.`cityId` = `cities`.`cityId`
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `dbsinterwood`.`customers`.`custId` AS `معرف العميل`,concat(`dbsinterwood`.`customers`.`fName`,\' \',`dbsinterwood`.`customers`.`midNName`,\' \',`dbsinterwood`.`customers`.`lName`) AS `اسم العميل`,`dbsinterwood`.`customers`.`phoneNo` AS `رقم الهاتف`,`dbsinterwood`.`customers`.`address` AS `العنوان`,`dbsinterwood`.`customers`.`eMail` AS `البريد الإلكتروني`,`dbsinterwood`.`cities`.`cityName` AS `المدينة الحالية`,`dbsinterwood`.`customers`.`accId` AS `رقم الحساب` from (`dbsinterwood`.`customers` join `dbsinterwood`.`cities` on((`dbsinterwood`.`customers`.`cityId` = `dbsinterwood`.`cities`.`cityId`))) where (`dbsinterwood`.`customers`.`cityId` = `dbsinterwood`.`cities`.`cityId`)
