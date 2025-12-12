class GrandFather {
    String name;
    String age;

    GrandFather(String name, String age) {
        this.name = name;
        this.age = age;
    }

    GrandFather() {
        this("บุญ1", "80");
    }

    String infoFamilyGrandFather() {
        return "ชื่อของปู่ : " + name + ", อายุ : " + age;
    }

    // ───────── Uncle ─────────
    static class Uncle {
        String name;
        String age;

        Uncle(String name, String age) {
            this.name = name;
            this.age = age;
        }

        Uncle() {
            this("บุญ2", "69");
        }

        String infoFamilyUncle() {
            return "ชื่อลุง : " + name + ", อายุ : " + age;
        }
    }

    // ───────── Father ─────────
    static class Father {
        String name;
        String age;

        Father(String name, String age) {
            this.name = name;
            this.age = age;
        }

        Father() {
            this("บุญ3", "54");
        }

        String infoFamilyFather() {
            return "ชื่อพ่อ : " + name + ", อายุ : " + age;
        }

        // ───────── Brother ─────────
        static class Brother {
            String name;
            String age;

            Brother(String name, String age) {
                this.name = name;
                this.age = age;
            }

            Brother() {
                this("บุญ4", "30");
            }

            String infoFamilyBrother() {
                return "ชื่อพี่ : " + name + ", อายุ : " + age;
            }

            // ───────── Niece ─────────
            static class Niece {
                String name;
                String age;

                Niece(String name, String age) {
                    this.name = name;
                    this.age = age;
                }

                Niece() {
                    this("บุญ5", "18");
                }

                String infoFamilyNiece() {
                    return "ชื่อหลาน : " + name + ", อายุ : " + age;
                }
            }
        }
    }

    // ───────── Me ─────────
    static class Me {
        String name;
        String age;

        Me(String name, String age) {
            this.name = name;
            this.age = age;
        }

        Me() {
            this("บุญ6", "20");
        }

        String infoFamilyMe() {
            return "ชื่อฉัน : " + name + ", อายุ : " + age;
        }

        // ───────── MyDog ─────────
        static class MyDog {
            String name;
            String age;

            MyDog(String name, String age) {
                this.name = name;
                this.age = age;
            }

            MyDog() {
                this("บุญ7", "1");
            }

            String infoFamilyMyDog() {
                return "ชื่อสุนัข : " + name + ", อายุ : " + age;
            }
        }
    }
}