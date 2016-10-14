/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2016/10/14 14:47:59                          */
/*==============================================================*/


alter table UserAccre
   drop primary key;

drop table if exists UserAccre;

alter table UserInfo
   drop primary key;

drop table if exists UserInfo;

/*==============================================================*/
/* Table: UserAccre                                             */
/*==============================================================*/
create table UserAccre
(
   Id                   varchar(20) not null comment '主键',
   UserId               varchar(20) not null comment '外键',
   OpenId               varchar(30) not null comment '授权标识'
);

alter table UserAccre comment '用户授权';

alter table UserAccre
   add primary key (Id);

/*==============================================================*/
/* Table: UserInfo                                              */
/*==============================================================*/
create table UserInfo
(
   UserId               varchar(20) not null comment '主键',
   UserName             varchar(20) not null comment '名称'
);

alter table UserInfo comment '用户信息表';

alter table UserInfo
   add primary key (UserId);

alter table UserAccre add constraint `FK_UserAccre.UserInfo` foreign key (UserId)
      references UserInfo (UserId) on delete restrict on update restrict;

