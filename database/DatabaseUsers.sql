CREATE USER 'CaseUser'@'localhost' IDENTIFIED BY 'CaseUser';
CREATE USER 'CaseAdmin'@'localhost' IDENTIFIED BY 'CaseAdmin';
GRANT ALL ON casemanager.* to 'CaseAdmin'@'localhost';
GRANT SELECT, UPDATE, DELETE, INSERT ON casemanager.* to 'CaseAdmin'@'localhost';
GRANT SELECT, UPDATE, DELETE, INSERT ON casemanager.* to 'CaseUser'@'localhost';