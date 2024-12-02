create table departemen
(
id_departemen serial primary key,
nama_dept character VARYING (20)
);


create SEQUENCE emp_id start 2023001;
create table karyawan
(
id_karyawan character VARYING (20) default 'EMP'|| nextval('emp_id') primary key,
nama character VARYING (20),
id_dept int,
FOREIGN KEY (id_dept) REFERENCES departemen (id_departemen)
);
