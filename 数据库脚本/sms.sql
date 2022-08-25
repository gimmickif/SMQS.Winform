/*
 Navicat MySQL Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 80029
 Source Host           : localhost:3306
 Source Schema         : sms

 Target Server Type    : MySQL
 Target Server Version : 80029
 File Encoding         : 65001

 Date: 12/07/2022 20:23:18
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for clazz
-- ----------------------------
DROP TABLE IF EXISTS `clazz`;
CREATE TABLE `clazz`  (
  `Clzno` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Clzname` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Clzno`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of clazz
-- ----------------------------
INSERT INTO `clazz` VALUES ('10', '软工10班');
INSERT INTO `clazz` VALUES ('11', '软工11班');
INSERT INTO `clazz` VALUES ('12', '软工12班');
INSERT INTO `clazz` VALUES ('13', '软工11班');
INSERT INTO `clazz` VALUES ('9', '软工9班');

-- ----------------------------
-- Table structure for course
-- ----------------------------
DROP TABLE IF EXISTS `course`;
CREATE TABLE `course`  (
  `Cno` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Cname` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Cno`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of course
-- ----------------------------
INSERT INTO `course` VALUES ('01', '英语');
INSERT INTO `course` VALUES ('02', '语文');

-- ----------------------------
-- Table structure for grade
-- ----------------------------
DROP TABLE IF EXISTS `grade`;
CREATE TABLE `grade`  (
  `Sno` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Cno` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Score` smallint NULL DEFAULT NULL,
  PRIMARY KEY (`Sno`, `Cno`) USING BTREE,
  INDEX `Cno`(`Cno` ASC) USING BTREE,
  INDEX `Sno`(`Sno` ASC) USING BTREE,
  CONSTRAINT `grade_ibfk_1` FOREIGN KEY (`Sno`) REFERENCES `student` (`Sno`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `grade_ibfk_2` FOREIGN KEY (`Cno`) REFERENCES `course` (`Cno`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of grade
-- ----------------------------
INSERT INTO `grade` VALUES ('200901021', '01', 70);
INSERT INTO `grade` VALUES ('200901021', '02', 80);
INSERT INTO `grade` VALUES ('200901022', '02', 90);

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student`  (
  `Sno` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Sname` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Clzno` char(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Sno`) USING BTREE,
  UNIQUE INDEX `Sname`(`Sname` ASC) USING BTREE,
  INDEX `student_ibfk_1`(`Clzno` ASC) USING BTREE,
  CONSTRAINT `student_ibfk_1` FOREIGN KEY (`Clzno`) REFERENCES `clazz` (`Clzno`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('200901021', '李四', '10');
INSERT INTO `student` VALUES ('200901022', '张三', '10');
INSERT INTO `student` VALUES ('209000909', '李斯', '9');
INSERT INTO `student` VALUES ('209001023', '王二', '10');

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo`  (
  `userid` char(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `pwd` char(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`userid`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of userinfo
-- ----------------------------
INSERT INTO `userinfo` VALUES ('123456', '123456');
INSERT INTO `userinfo` VALUES ('201901913', '12345678');
INSERT INTO `userinfo` VALUES ('202391', '123456');
INSERT INTO `userinfo` VALUES ('209001030', '209001030');

SET FOREIGN_KEY_CHECKS = 1;
